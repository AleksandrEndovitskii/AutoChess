# AutoChess

Условия:
- Для выполнения задания необходимо использовать Unity 2018+ и C# без использования сторонних библиотек и кода.
- Визуальное исполнение в плане текстур и анимаций не имеет значение, для упрощения работы можно просто использовать геометрические фигуры.
- Итоговый результат должен хорошо работать на любом мобильном устройстве.
- Приоритет на реализации в 2D
- Приветствуются пояснения из разряда "Вот тут я сделал вот так, чтобы сэкономить время, но в реальных условиях я бы сделал вот так".

Задача:
1) Создать игровую сцену на которой расположить поле битвы в виде шахматной доски 6х8 клеток
2) Добавить в интерфейс кнопку "Начать бой"
3) При нажатии на кнопку "Начать бой":
- Кнопка "Начать бой" скрывается
- С правой стороны (правые 3 ряда) должны появится юниты Команды 1
- С левой стороны (левые 3 ряда) должны появится юниты Команды 2
- При каждом начале боя на каждой стороне должно появляться рандомное количество юнитов от 2 до 5
- Запускается бой юнитов
6) У юнитов должна быть полоса здоровья которая будет уменьшаться при получении урона от юнита противоположной команды
7) Когда у юнита падает жизнь до нуля, он уничтожается
8) Когда все юниты одной из команды уничтожены, все перезапускается и идет ожидание нажатия на кнопку "Начать бой"

- Логика боя:
1) После появления юнитов, они должны найти ближайшего (близость определяется количеством ходов по клеткам, а не прямым расстоянием) врага (юнит противоположной команды) до которого они могут дойти и начать движение к нему
2) Юниты должны ходить по шахматным ячейкам, т.е. поиск пути и передвижение идет в рамках сетки 6х8. По горизонтали, вертикали и диагонали
3) Ходы должны рассчитываться очередно и после каждой смены ячейки. Т.е. после того как юнит перешел на новую ячейку, повторно пересчитывать путь и искать ближайшего врага.
4) После того как в соседней ячейки окажется враг, юнит должен атаковать его
5) После того как враг уничтожен, должен начаться поиск следующей цели, и так пока не будут уничтожены все юниты противоположной команды
6) Юниты должны атаковать по прямой и диагонали

На что будет обращено внимание:
1) Качество реализации
2) Понятность и чистота кода
3) Производительность и оптимизация
4) Работоспособность
