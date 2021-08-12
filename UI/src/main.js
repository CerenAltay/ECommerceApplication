import Vue from 'vue';
import App from './App.vue';

Vue.config.productionTip = true;

import "bootstrap/dist/css/bootstrap.min.css";
import "font-awesome/css/font-awesome.min.css";

import VueRouter from 'vue-router';

import store from "./store";
import router from "./router";

Vue.use(VueRouter);

new Vue({
    render: h => h(App),
    store,
    router
}).$mount('#app');
