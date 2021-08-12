<template>
  <div>
    <!-- <a class="navbar-brand" href="/">Fresh Grocery Shopping</a>
    <button
      class="navbar-toggler"
      type="button"
      data-toggle="collapse"
      data-target="#navbarsExampleDefault"
      aria-controls="navbarsExampleDefault"
      aria-expanded="false"
      aria-label="Toggle navigation"
    >
      <span class="navbar-toggler-icon"></span>
    </button> -->
    
    <Categories />
    <Products />
  </div>
</template>

<script>
import { mapState } from "vuex";
import Categories from "./Categories.vue";
import Products from "./Products.vue";

export default {
  components: {
    Categories,
    Products,
  },
  computed: {
    ...mapState(["categories"]),
    ...mapState(["products"]),
    ...mapState(["orders"]),
  },
};
</script>


