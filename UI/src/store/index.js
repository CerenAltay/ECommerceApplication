import Vue from "vue";
import Vuex from "vuex";
import Axios from "axios";

Vue.use(Vuex);

//remark:url that the API runs
const baseUrl = "https://localhost:44321/api";

const pagesUrl = `${baseUrl}/pages`;
const categoriesUrl = `${baseUrl}/categories`;
const productsUrl = `${baseUrl}/products`;
const ordersUrl = `${baseUrl}/orders`;

export default new Vuex.Store(
    {
        strict: true,
        state: {
            pages: [],
            categories:[],
            products:[],
            orders:[]
        },
        mutations: {
            setPages(state, pages) {
                state.pages = pages;
            },
            setCategories(state, categories) {
                state.categories = categories;
            },
            setProducts(state, products) {
                state.products = products;
            },
            setOrders(state, orders) {
                state.orders = orders;
            }
        },
        actions: {
            async setPagesAction(context) {
                context.commit("setPages", (await Axios.get(pagesUrl)).data);
            },
            async setCategoriesAction(context) {
                context.commit("setCategories", (await Axios.get(categoriesUrl)).data);
            },
            async setProductsAction(context) {
                context.commit("setProducts", (await Axios.get(productsUrl)).data);
            },
            async setOrdersAction(context) {
                context.commit("setOrders", (await Axios.get(ordersUrl)).data);
            }
        }
    })