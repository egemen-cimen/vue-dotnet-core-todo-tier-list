import Vue from 'vue'
import VueRouter from 'vue-router'
import Backlog from '@/components/Backlog';
import KanbanTierListBoard from '@/components/KanbanTierListBoard'

Vue.use(VueRouter)

const routes = [
	{
		path: '/backlog',
		component: Backlog,
	},
	{
		path: '/board',
		component: KanbanTierListBoard,
	},
	{
		path: '*',
		redirect: '/backlog',
	},
]

const router = new VueRouter({
	routes
})

export default router
