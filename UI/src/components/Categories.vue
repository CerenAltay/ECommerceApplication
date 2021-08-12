<template>
  <nav class="navbar navbar-expand-md navbar-light bg-light">
    <a class="navbar-brand" href="/">Categories</a>
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
      <ul class="navbar-nav mr-auto">
        <li class="nav-item active" v-for="(p, i) in categories" :key="i">
          {{ p.name }}
          <button class="btn btn-primary" @click="getCategory()">
            Choose category
          </button>
        </li>
        <p>
        </p>
      </ul>
    </div>
  </nav>
</template>

<script>
import { mapState } from "vuex";
export default {
  // data() {
  //   return { category:{}};
  // },
  components: {},
  computed: {
    ...mapState(["categories"]),
  },
  methods: {
    getCategory() {
      let uri = "https://localhost:44321/api/categories" + this.$route.params.id;
      this.axios.get(uri).then((response) => {
        console.log(response);
        this.category = response.data;
      });
    },
  },
};
</script>


