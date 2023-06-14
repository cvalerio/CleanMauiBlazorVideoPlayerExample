const video = {
  playLocal: function (elementId) {
    document.getElementById(elementId).src = "videos/mov_bbb.mp4";

  },

  playRemote: function (elementId) {
    document.getElementById(elementId).src = "https://www.w3schools.com/html/mov_bbb.mp4";

  },

  init: function (elementId) {
    document.getElementById(elementId).addEventListener('error', (err) => {
      console.error(err.target.error.message);
    });
  }
}

window.videoManager = video;
