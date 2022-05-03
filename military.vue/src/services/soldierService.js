import axios from "axios";
import { ref } from 'vue'

const soldierService = (function(){

    const soldiers = ref([]);

    // DONE: url til PokemonController
    const soldierControllerUrl = "https://localhost:7088/soldier";

    // DONE: url til endepunkt for bildeopplast
    const imageUploadControllerUrl = "https://localhost:7088/imageUpload/postImage";
    
    ( async ()=> {
        // Todo: sette pokemons ved last av pokemonService
        const request = await axios.get(soldierControllerUrl);
        soldiers.value = request.data;
    })()

    const getAll = () => soldiers;

    // TODO: postPokemon
    const postSoldier = ( newSoldier, image ) => {

        axios.post(soldierControllerUrl, newSoldier); // Lagrer ny pokemon med navn og image i databasen

        axios({ // lagrer bilde i wwwroot/images
            method: "POST",
            url: imageUploadControllerUrl,
            data: image,
            config: { header: { "Content-Type": "multipart/form-data" } }
        });

        // TODO: oppdater pokemons-ref med push av ny pokemon pokemons.value.push(newPokemon)
    }

    return {
        getAll,
        postSoldier
    }

}())

export default soldierService;