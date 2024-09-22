using System.Net.Http.Json;
using Models;

namespace Services;
public class TodoService(HttpClient client)
{
    private readonly HttpClient _client = client;

    public async Task<Todo[]> GetAllAsync()
    {
        var todos = await _client.GetFromJsonAsync<Todo[]>("todos");
        return todos ?? [];
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var response = await _client.DeleteAsync($"todos/{id}");
        return response.IsSuccessStatusCode;
    }

    public async Task ToggleStatus(Todo todo)
    {
        todo.IsCompleted = !todo.IsCompleted;
        var response = await _client.PutAsJsonAsync($"todos/{todo.Id}", todo);
        if(!response.IsSuccessStatusCode)
        {
            todo.IsCompleted = !todo.IsCompleted;
        }
    }
}
