<template>
    <nav class="navbar navbar-expand-md navbar-dark bg-dark">
        <a class="navbar-brand" href="/">Fresh Grocery Shopping</a>
         <a class="navbar-brand" href="/categories">Categories</a>
          <a class="navbar-brand" href="/products">Products</a>
         <a class="float-right" href="/orders">Cart</a>
    </nav>

</template>

<script>
    import { mapState } from 'vuex';
    export default {
        components: {},
        computed: {
            ...mapState(["pages"])
        },
    };
</script>


