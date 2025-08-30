
<h1 align="center"> [GitLab](https://gitlab.workbench.network/Workbench-Team/space-station-14) | [GitHub](https://github.com/Workbench-Team/space-station-14) </h1>
=======
<div class="header" align="center">  
<img alt="Space Station 14" width="880" height="300" src="https://raw.githubusercontent.com/space-wizards/asset-dump/de329a7898bb716b9d5ba9a0cd07f38e61f1ed05/github-logo.svg">  
</div>

Space Station 14 это ремейк SS13, который работает на собственном движке [Robust Toolbox](https://github.com/space-wizards/RobustToolbox), написанном на C#.

Это репозиторий русскоязычной версии Space Station 14 основной целью которого является перевод и только перевод игры на русский язык. Если Вы хотите использовать наши (от Workbench Team) наработки для игры, перейдите в [arumoon-server ветку](https://gitlab.workbench.network/Workbench-Team/space-station-14/-/tree/arumoon-server).

Если Вам нужно захостить русскоязычный сервер для SS14, этот репозиторий это то что Вам нужно. Если Вы хотите делать нововведения для основной версии игры, перейдите в [репозиторий официальной версии игры](https://github.com/space-wizards/space-station-14).

## Ссылки

<div class="header" align="center">  

[Сайт игры](https://spacestation14.com/) | [Workbench Discord](https://discord.gg/Dxqz5gy) | [Workbench Revolt](https://rvlt.gg/wcYASVKF) | [Steam игры](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Скачать лаунчер](https://spacestation14.com/about/nightlies/)  

</div>

## Документация

На официальном сайте с [документацией](https://docs.spacestation14.com/) имеется вся необходимая информация о контенте SS14, движке, дизайне игры и многом другом.
Помимо этого, ознакомьтесь с этими ресурсами для получения информации о лицензии и авторстве:
- [Общая атрибуция Robust](https://docs.spacestation14.com/en/specifications/robust-generic-attribution.html)  
- [Robust Station Image](https://docs.spacestation14.com/en/specifications/robust-station-image.html)

Также имеется множество ресурсов для новых контрибьюторов проекта.

## Вклад

Если Вы хотите предложить перевод или редактирование уже переведённого контента, мы с радостью ждём Ваши изменения на нашем [основном репозитории GitLab](https://gitlab.workbench.network/Workbench-Team/space-station-14) (рекомендуется) или [зеркале GitHub](https://github.com/Workbench-Team/space-station-14). Если Вам нужна помощь, посмотрите текущие [обсуждения в GitLab](https://gitlab.workbench.network/Workbench-Team/space-station-14/-/issues) или лучше перейдите на Discord или Revolt сервер Workbench Team для более удобной коммуникации.

## Готовая сборка

Статус сборки: [![pipeline status](https://gitlab.workbench.network/Workbench-Team/space-station-14/badges/master-ru/pipeline.svg)](https://gitlab.workbench.network/Workbench-Team/space-station-14/-/commits/master-ru)

Готовые билды сборки Вы можете скачать из [CDN хостинга (быстро)](https://ss14.lolicon.monster/builds/master-ru-builds.html) или [артефактов CI/CD (медленно)](https://gitlab.workbench.network/Workbench-Team/space-station-14/-/pipelines?page=1&scope=all&ref=master-ru&status=success)

## Самостоятельная сборка

1. Склонируйте этот репозиторий:
```shell
git clone https://github.com/Workbench-Team/space-station-14.git
```
2. Зайдите в папку проекта и запустите скрипт `RUN_THIS.py` для инициализации субмодулей и скачивания движка:
```shell
cd space-station-14
python RUN_THIS.py
```
3. Соберите решение:
Создайте сборку через Visual Studio или `dotnet build` в терминале.

[Более детальная инструкция для сборки.](https://docs.spacestation14.com/en/general-development/setup.html)

## Лицензия

Весь код репозитория лицензирован под [MIT](https://gitlab.workbench.network/Workbench-Team/space-station-14/blob/master-ru/LICENSE.TXT).

Большинство ассетов лицензированы под [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) если не имеют иное. Ассеты имеют свою лицензию и авторские права в файле метаданных. [Пример](https://gitlab.workbench.network/Workbench-Team/space-station-14/blob/master-ru/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).

> [!NOTE]
> Обратите внимание, что некоторые ассеты лицензированы на некоммерческой основе [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) или аналогичной некоммерческой лицензией, и их необходимо удалить, если Вы хотите использовать этот проект в коммерческих целях.
