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
        isStateDirty: true
    },
    mutations: {
        addListItem(state, item, id) {
            if (id && id > state.itemId) {
                state.itemId = id
            }
            else {
                state.itemId += 1;
            }
            switch (item.status) {
                case 0:
                    state.items.backlogItems.push(Object.assign(item, { id: state.itemId }));
                    break;
                case 1:
                    state.items.sTodoItems.push(Object.assign(item, { id: state.itemId }));
                    break;
                case 2:
                    state.items.aTodoItems.push(Object.assign(item, { id: state.itemId }));
                    break;
                case 3:
                    state.items.bTodoItems.push(Object.assign(item, { id: state.itemId }));
                    break;
                case 4:
                    state.items.cTodoItems.push(Object.assign(item, { id: state.itemId }));
                    break;
                case 5:
                    state.items.dTodoItems.push(Object.assign(item, { id: state.itemId }));
                    break;
                case 6:
                    state.items.doneItems.push(Object.assign(item, { id: state.itemId }));
                    break;
            }
        },
        updateListItems(state, payload) {
            if (state.items[payload.id] !== state.items.trashedItems)
                state.items[payload.id] = payload.items;
        },
        setDirty(state) {
            state.isStateDirty = true;
        },
        setNotDirty(state) {
            state.isStateDirty = false;
        }
    },
});