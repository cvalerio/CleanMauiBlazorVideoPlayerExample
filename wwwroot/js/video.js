const video = {
  playLocal: function (elementId) {
    const videoEl = document.getElementById(elementId);
    if (/^blob/.test(videoEl.src)) {
      URL.revokeObjectURL(videoEl.src);
    }
    videoEl.src = "videos/mov_bbb.mp4";
  },

  playLocalWithPrefetch: async function (elementId) {
    const blob = await fetch("videos/mov_bbb.mp4").then(r => r.blob());
    const url = URL.createObjectURL(blob);
    document.getElementById(elementId).src = url;
  },

  playRemote: function (elementId) {
    const videoEl = document.getElementById(elementId);
    if (/^blob/.test(videoEl.src)) {
      URL.revokeObjectURL(videoEl.src);
    }
    videoEl.src = "https://www.w3schools.com/html/mov_bbb.mp4";
  },

  init: function (elementId) {
    const videoEl = document.getElementById(elementId);
    videoEl.addEventListener('error', (err) => {
      console.error(err.target.error.message);
    });
    videoEl.addEventListener('loadedmetadata', (e) => {
      console.log('loaded video metadata', e.target.duration);
    });
    videoEl.addEventListener('loadeddata', (e) => {
      console.log('loaded video data', e.target.duration);
    });
    videoEl.addEventListener('playing', (e) => {
      console.log('playing video', e.target.duration);
    });
    videoEl.addEventListener('pause', (e) => {
      console.log('pause video', e.target.duration);
    });
  }
}

window.videoManager = video;
