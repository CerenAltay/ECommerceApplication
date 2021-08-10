<template>
  <nav class="navbar navbar-expand-md navbar-light bg-light">
    <a class="navbar-brand" href="/">Products</a>
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
    </button>

    <div class="collapse navbar-collapse" id="navbarsExampleDefault">
      <p>
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active" v-for="(p, i) in products" :key="i">
          <h3>{{ p.name }}</h3>
          <p>
          <img :src=" p.image "/>
          </p>
           <p>
                        {{ p.description }}
                    </p>
                    <p>
                        {{ p.price +' £' }}
                    </p>
                      <p>
                        <button
                            class="btn btn-primary"
                            @click="handleAddProduct(p)"
                        >
                            Add to cart
                        </button>
                    </p>
        </li>
      </ul>
      </p>
    </div>
  </nav>
</template>

<script>
import { mapState } from "vuex";
export default {
  components: {},
  computed: {
    ...mapState(["products"]),
  },
  methods: {
    handleAddProduct(product) {
      this.addProduct(product);
    },
  },
};
</script>


