<template>
    <section>
        <h2>Legg til ny Soltad</h2>       
        <!-- TODO: legge til elementer for å lagre ny Pokemon og laste opp bilde-->
        <div>
            <label>Navn</label>
            <input v-model="name" type="text">
        </div>
        <div>
            <label>Velg et bilde</label>
            <input @change="setImage" type="file">
        </div>
        <input @click="postPokemon" type="button" value="Lagre soldat">
        <!-- TODO?: image preview med URL.createObjectUrl()? -->
    </section>
</template>

<script>
import { reactive, toRefs } from "vue";
import soldierService from "../../services/soldierService.js";

export default {
    setup(){
        //URL.createObjectURL()
        // TODO: funksjonalitet for å få tak i objekt og bilde som skal sendes til pokemonService for POST til Web Api

        const image = new FormData();

        const formSoldier = reactive({
            name: "",
            age: "",
            active: "",
            image: ""
        }); 

        const setImage = (e) => {
            image.append("file", e.target.files[0]); // bildeobjekt for bildeopplast
            formSoldier.image = e.target.files[0].name; // sett navn på bildet i prop image til ny Pokemon
        }

        const postSoldier = () => {            

            const newSoldier = {
                name: formSoldier.name,
                age: formSoldier.age,
                active: formSoldier.active,
                image: formSoldier.image
            };

            soldierService.postSoldier( newSoldier, image );
        }

        return {
            setImage,
            postSoldier,
            ...toRefs(formSoldier)
        }

    }    
}
</script>