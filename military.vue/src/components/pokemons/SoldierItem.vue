<template>
    <article>
        <h3>{{ name }} (id: {{ id }})</h3>
        <p>Aktiv: {{ active }}</p>
        <p>Alder: {{ age }}</p>
        <!-- Todo: Sette inn bilde med referanse til domene / images / bildenavn -->
        <img :src="`https://localhost:7088/images/${image}`">
    </article>
</template>

<script> //PAUSE TIL 13:15
export default {
    props: {
        id: Number,
        name: String,
        age: Number, 
        active: Boolean, 
        image: String
    }
}
</script>