import Vue from "vue";
import VueRouter from "vue-router";

// import Pages from "../components/Pages";
import Categories from "../components/Categories";
import Products from "../components/Products";
import Orders from "../components/Orders";
import Checkout from "../components/Checkout";


// import dataStore from "../store";

Vue.use(VueRouter);

export default new VueRouter({
    mode: "history",
    // routes: [
    //     // { path: "/categories/:category", component: Products },
    //     { path: "/categories/", component: Categories },
    //     { path: "/products/", component: Products },
    //     { path: "/cart", component: Orders },
    //     { path: "/checkout", component: Checkout },
    //     // { path: "/thanks", component: Thanks },
    //     // { path: "/login", component: Login },
    //     { path: "*", redirect: "/" },
    // ],
});