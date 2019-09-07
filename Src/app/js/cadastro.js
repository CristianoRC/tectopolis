function cadastar(params) {
  axios.post("https://api-tectopolis.azurewebsites.net/api/user", {
    name: document.getElementById('name').value,
    ImageUrl: document.getElementById('imgurl').value,
    Password: document.getElementById('passwordCadastro').value,
    Email: document.getElementById('emailCadastro').value,
  }).then(response => {
    alert("Registro criado")
  })
}