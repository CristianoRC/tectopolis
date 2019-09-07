window.onload = function () {
  this.getAllPosts();
  this.getAllUsers();
};

function getAllUsers() {
  const constendDiv = document.getElementById("contentUser");
  axios.get('https://api-tectopolis.azurewebsites.net/api/user').then(response => {
    const cards = response.data.map(post => createCardUser(post))

    cards.map(card => {
      constendDiv.innerHTML += card
    })
  });
}

function getAllPosts() {
  const constendDiv = document.getElementById("content");
  axios.get('https://api-tectopolis.azurewebsites.net/api/post').then(response => {
    const cards = response.data.map(post => createCard(post))

    cards.map(card => {
      constendDiv.innerHTML += card
    })
  });
}


function createCardUser(data) {
  return `<div class="card mb-3 rounded-0">
  <div class="row no-gutters">
      <div class="col-md-6">
          <img src="${data.imageUrl}" style=" max-height: 15vh;" class="img-fluid" alt="...">
      </div>
      <div class="col-md-6">
          <p class="card-text sugested-name" style="text-align: left;">${data.name}</h7>
      </div>
  </div>
</div>`
}


function createCard(data) {
  return `<div class="card text-center rounded-0">
      <div class="card-header headder-noticia">
          <ul class="nav">
              <li class="nav-item img-user-feed">
                  <img src="https://cdn.iconscout.com/icon/free/png-256/avatar-367-456319.png" style="float:left; width: 49px; height: 49px; ">
              </li>
              <li class="nav-item">
                  <h5>@${data.creator}</h5>
              </li>
          </ul>
      </div>
      <div class="card-body">
          <h5 class="card-title">Noticia</h5>
          <p class="card-text">${data.description}</p>
      </div>
    </div>`
}