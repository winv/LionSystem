
export default [
  {
    path: '/lionadminui/login',
    name: 'Login',
    component: () => import('@/lionadminviews/login/index.vue')
  },
  {
    path: '/lionadminui',
    name: 'Index',
    component: () => import('@/lionadminviews/main/index.vue')
  }
]
