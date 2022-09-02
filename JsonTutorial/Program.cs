using JsonTutorial;

using System.Text.Json;

User noah = new User {
    Id = 1, Username = "nphence", Password = "password",
    Firstname = "Noah", Lastname = "Phence",
    Phone = "411", Email = "nphence@gmail.com",
    IsReviewer = true, IsAdmin = false
};

JsonSerializerOptions options = new JsonSerializerOptions() {
    PropertyNameCaseInsensitive = true,
    WriteIndented = true
};

var json = JsonSerializer.Serialize(noah, options);

User? noahConverted = JsonSerializer.Deserialize<User>(json);

var v = 1;