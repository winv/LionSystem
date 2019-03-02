import Vue from 'vue'
import iView from 'iview'
import router from './router'
import App from './app.vue'
import 'iview/dist/styles/iview.css'

Vue.use(iView)
iView.LoadingBar.config({
  color: '#2c3e50',
  height: 1
})
/* eslint-disable no-new */
new Vue({
  el: '#app',
  router: router,
  render: h => h(App)
})
