import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

/**
 * The mutation named addListItem is a method which takes the current state
 * and an item as arguments.
 * 
 * The item's then pushed into state.items.todoItems using Object.assign.
 * 
 */
export default new Vuex.Store({
    state: {
        items: {
            todoItems: [],
        },
        itemId: 0,
    },
    mutations: {
        addListItem(state, item) {
            state.itemId += 1;
            state.items.todoItems.push(Object.assign(item, { id: state.itemId}));
        }
    },
});