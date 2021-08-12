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
                  <button class="btn btn-primary" @click="handleAddProduct(p)">
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
  // data() {
  //   return;
  //   {
  //     this.products; {
  //     }
  //   }
  // },
  productAdded: function () {
    this.getProducts();
  },
  components: {},
  computed: {
    ...mapState(["products", "productImages"]),
  },
  methods: {
    //...mapMutations(["setCurrentCategory", "setCurrentPage"]),
    // ...mapActions(["setProductsByCategoryAction"]),
    // ...mapActions({addProduct: "cart/AddProduct"}),
    getProducts() {
      let uri = "https://localhost:44321/api/products" + this.$route.params.id;
      this.axios.get(uri, this.product).then((response) => {
        console.log(response)
        this.products = response.data;
      });
    },
    handleAddProduct(product) {
      this.addProduct(product);
    },
  },
};
</script>


