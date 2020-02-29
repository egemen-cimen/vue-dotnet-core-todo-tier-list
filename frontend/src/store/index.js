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
            backlogItems: [],
            sTodoItems: [],
            aTodoItems: [],
            bTodoItems: [],
            cTodoItems: [],
            dTodoItems: [],
            doneItems: [],
            trashedItems: []
        },
        itemId: -1,
    },
    mutations: {
        addListItem(state, item) {
            state.itemId += 1;
            state.items.backlogItems.push(Object.assign(item, { id: state.itemId }));
        },
        updateListItems(state, payload) {
            if (state.items[payload.id] !== state.items.trashedItems)
                state.items[payload.id] = payload.items;
        }
    },
});