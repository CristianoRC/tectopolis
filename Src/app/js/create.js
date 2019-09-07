function createPost() {
  axios.post('https://api-tectopolis.azurewebsites.net/api/post', {
    Creator: document.getElementById("name").value,
    Description: document.getElementById("description").value,
    UserId: "33ec4878-24b6-456c-96a7-454504125955"
  }).then(response => {
    alert("Criado com sucesso")
  });
}