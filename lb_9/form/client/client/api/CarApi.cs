using client.api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.api
{
    public class CarApi
    {
        public CarApi() { }

        public IEnumerable<CarDto.CarDto> getAllCars()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51346/api/");

                var responseTask = client.GetAsync("Car");
                responseTask.Wait();

                var getResult = responseTask.Result;
                if (getResult.IsSuccessStatusCode)
                {
                    var readTask = getResult.Content.ReadAsAsync<IEnumerable<CarDto.CarDto>>(); // Предполагая, что вы ожидаете коллекцию объектов типа Car.
                    readTask.Wait();

                    var cars = readTask.Result;

                    return cars;

                }
                else
                {
                    MessageBox.Show($"Error: {getResult.StatusCode}");
                    return null;
                }
            }
        }

        public IEnumerable<CarDto.CarDto> getCarInformationById(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51346/api/");

                var responseTask = client.GetAsync($"Car/{id}");
                responseTask.Wait();

                var getResult = responseTask.Result;
                if (getResult.IsSuccessStatusCode)
                {
                    var readTask = getResult.Content.ReadAsAsync<IEnumerable<CarDto.CarDto>>(); // Предполагая, что вы ожидаете коллекцию объектов типа Car.
                    readTask.Wait();

                    var cars = readTask.Result;

                    return cars;

                }
                else
                {
                    MessageBox.Show($"Error: {getResult.StatusCode}");
                    return null;
                }
            }
        }

        public void deleteCarID(string id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51346/api/");

                // Отправка DELETE-запроса для удаления объекта Car с указанным идентификатором
                var deleteTask = client.DeleteAsync($"Car/{id}");
                deleteTask.Wait();

                var deleteResult = deleteTask.Result;
                if (deleteResult.IsSuccessStatusCode)
                {
                    // Обработка успешного удаления, если это необходимо
                    MessageBox.Show("Car deleted successfully");
                }
                else
                {
                    // Обработка ошибки удаления
                    MessageBox.Show($"Error: {deleteResult.StatusCode}");
                }
            }
        }
        
        public void updateCarByID(string car_id, string name, int price)
        {
            using (var client = new HttpClient())
            {
                // Устанавливаем базовый адрес вашего API
                client.BaseAddress = new Uri("http://localhost:51346/api/");

                // Создаем объект, представляющий данные для обновления
                var data = new CarUpdateDto
                {
                    car_id = int.Parse(car_id),
                    name = name,
                    price = price
                };

                // Отправляем запрос на сервер с использованием HTTP PUT или другого подходящего метода
                var response = client.PutAsJsonAsync($"Car/{car_id}", data).Result;

                // Обработка ответа от сервера
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Car updated successfully");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }


        public void CreateCarBy(string car_id, string name, int price)
        {
            using (var client = new HttpClient())
            {
                // Устанавливаем базовый адрес вашего API
                client.BaseAddress = new Uri("http://localhost:51346/api/");

                // Создаем объект, представляющий данные для создания новой записи
                var data = new CarCreateDto
                {
                    name = name,
                    price = price
                };

                // Отправляем POST-запрос на сервер с использованием метода PostAsJsonAsync
                var response = client.PostAsJsonAsync("Car", data).Result;

                // Обработка ответа от сервера
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Car created successfully");
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode}");
                }
            }
        }
    }
}
