---
layout: default
title: Метод Audio.GetRecommendations
permalink: audio/getRecommendations/
comments: true
---
# Метод Audio.GetRecommendations
Возвращает список рекомендуемых аудиозаписей на основе списка воспроизведения заданного пользователя или на основе одной выбранной аудиозаписи.

Страница документации ВКонтакте [audio.getRecommendations](https://vk.com/dev/audio.getRecommendations).
## Синтаксис
``` csharp
public ReadOnlyCollection<Audio> GetRecommendations(
	long? userId = null,
	uint? count = null,
	uint? offset = null,
	bool shuffle = true,
	string targetAudio = ""
)
```

## Параметры
+ **targetAudio** - Идентификатор аудиозаписи, на основе которой будет строиться список рекомендаций. Используется вместо параметра uid. Идентификатор представляет из себя разделённые знаком подчеркивания id пользователя, которому принадлежит аудиозапись, и id самой аудиозаписи. Если аудиозапись принадлежит сообществу, то в качестве первого параметра используется -id сообщества. строка
+ **userId** - Идентификатор пользователя для получения списка рекомендаций на основе его набора аудиозаписей (по умолчанию — идентификатор текущего пользователя). положительное число
+ **offset** - Смещение относительно первой найденной аудиозаписи для выборки определенного подмножества. положительное число
+ **count** - Количество возвращаемых аудиозаписей. положительное число, максимальное значение 1000, по умолчанию 100
+ **shuffle** - 1 — включен случайный порядок. флаг, может принимать значения 1 или 0

## Результат
После успешного выполнения возвращает список объектов audio. Обратите внимание, что ссылки на аудиозаписи привязаны к ip адресу.

## Пример
``` csharp
// Пример кода
```

## Версия Вконтакте API v.5.44
Дата обновления: 26.01.2016 19:20:10