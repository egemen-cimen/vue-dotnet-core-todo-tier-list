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
        addListItem(state, item) {
            if (item.id && item.id > state.itemId) {
                state.itemId = item.id;
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
            state.items[payload.id] = payload.items;

            var status;
            switch (payload.id) {
                case "backlogItems":
                    status = 0;
                    break;
                case "sTodoItems":
                    status = 1;
                    break;
                case "aTodoItems":
                    status = 2;
                    break;
                case "bTodoItems":
                    status = 3;
                    break;
                case "cTodoItems":
                    status = 4;
                    break;
                case "dTodoItems":
                    status = 5;
                    break;
                case "doneItems":
                    status = 6;
                    break;
                default:
                    status = 7;
                    break;
            }

            for (var i = 0; i < state.items[payload.id].length; i++) {

                state.items[payload.id][i].status = status;
            }

            /*
            if (state.items[payload.id] === state.items.trashedItems) {
                state.
            }
            */

        },
        setDirty(state) {
            state.isStateDirty = true;
        },
        setNotDirty(state) {
            state.isStateDirty = false;
        }
    },
});