using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Префаб объекта, который нужно спавнить
    public float spawnInterval = 2f; // Интервал между спавнами объектов
    public float minX = -8f; // Минимальное значение X
    public float maxX = 8f;  // Максимальное значение X
    public float minY = -4f; // Минимальное значение Y
    public float maxY = 4f;  // Максимальное значение Y

    private float timer;

    void Update()
    {
        // Увеличиваем таймер с течением времени
        timer += Time.deltaTime;

        // Проверяем, прошел ли интервал для спавна нового объекта
        if (timer >= spawnInterval)
        {
            // Спавним объект в случайной позиции
            SpawnObject();
            // Сбрасываем таймер
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        // Генерация случайной позиции внутри указанных границ
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector2 spawnPosition = new Vector2(randomX, randomY);

        // Создаём объект в случайной позиции
        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}
