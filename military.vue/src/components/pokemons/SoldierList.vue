<template>
    <section>
        <h2>Soldater</h2>
        <soldier-item
            v-for="(soldier, i) in soldiers"
            :key="i"
            :id="soldier.id"
            :name="soldier.name"
            :active="soldier.active"
            :age="soldier.age"
            :image="soldier.image"
        ></soldier-item>
    </section>
</template>

<script>
import SoldierItem from "./SoldierItem.vue"
import soldierService from "../../services/soldierService.js"

export default {
    setup(){
        const soldiers = soldierService.getAll();
        
        return {
            soldiers
        }
    },
    components: {
        SoldierItem
    }
}
</script>