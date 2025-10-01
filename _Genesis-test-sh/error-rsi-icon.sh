#!/bin/bash

# Проверяем все .rsi в /Textures/Genesis на проблему icon/png <-> meta.json

echo "Проверка соответствия icon.png и meta.json 'icon' для /Textures/Genesis/*.rsi..."

problem_found=0

# Проходим по всем .rsi директориям
find Resources/Textures/Genesis -type d -name "*.rsi" | while read -r rsi_dir; do
    # Проверяем наличие icon.png
    has_icon_file=0
    if [[ -f "$rsi_dir/icon.png" ]]; then
        has_icon_file=1
    fi

    # Проверяем наличие meta.json и "name": "icon" в states
    has_icon_meta=0
    if [[ -f "$rsi_dir/meta.json" ]]; then
        if grep -q '"name"[[:space:]]*:[[:space:]]*"icon"' "$rsi_dir/meta.json"; then
            has_icon_meta=1
        fi
    fi

    # Ищем проблему
    if [[ $has_icon_file -eq 1 && $has_icon_meta -eq 0 ]]; then
        echo "❌ ПРОБЛЕМА: $rsi_dir — icon.png есть, но нет 'icon' в meta.json!"
        problem_found=1
    fi
    if [[ $has_icon_file -eq 0 && $has_icon_meta -eq 1 ]]; then
        echo "❌ ПРОБЛЕМА: $rsi_dir — 'icon' есть в meta.json, но нет icon.png!"
        problem_found=1
    fi
done

if [[ $problem_found -eq 0 ]]; then
    echo "✅ Нет проблем с icon.png и meta.json 'icon' в /Textures/Genesis/*.rsi!"
    exit 0
else
    echo "❌ Найдены проблемы в /Textures/Genesis/*.rsi. Исправьте, иначе тест packaging будет падать!"
    exit 1
fi
