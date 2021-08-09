<template>
  <div class="container">
    <Header />
   
      <Body />
      <Categories />
      <Products />
      <Orders/>
    </div>

</template>

<script>
import { mapActions } from "vuex";

import Header from "./components/Header.vue";
import Body from "./components/Body.vue";
import Categories from "./components/Categories.vue";
import Products from "./components/Products.vue";
import Orders from "./components/Orders.vue";

export default {
  components: {
    Header,
    Body,
    Categories,
    Products,
    Orders,
  },
  methods: {
    ...mapActions(["setPagesAction"]),
    ...mapActions(["setCategoriesAction"]),
    ...mapActions(["setProductsAction"]),
    ...mapActions(["setOrdersAction"]),
  },
  async created() {
    this.setPagesAction();
    this.setCategoriesAction();
    this.setProductsAction();
    this.setOrdersAction();
  },
};
</script>


