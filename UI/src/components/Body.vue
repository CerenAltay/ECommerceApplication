<template>
  <nav class="navbar navbar-expand-md navbar-dark bg-dark">
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

    <div class="collapse navbar-collapse" id="navbarsExampleDefault">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active" v-for="(p, i) in categories" :key="i">
          {{ p.name }}
        </li>
      </ul>
    </div>
      <div class="collapse navbar-collapse" id="navbarsExampleDefault">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active" v-for="(p, i) in products" :key="i">
          {{ p.name }}
        </li>
      </ul>
    </div>
      <div class="collapse navbar-collapse" id="navbarsExampleDefault">
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active" v-for="(p, i) in orders" :key="i">
          {{ p.name }}
        </li>
      </ul>
    </div>
  </nav>
</template>

<script>
import { mapState } from "vuex";
export default {
  components: {},
  computed: {
    ...mapState(["categories"]),
    ...mapState(["products"]),
    ...mapState(["orders"]),
  },
};
</script>


