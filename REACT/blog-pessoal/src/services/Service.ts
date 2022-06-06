import axios from 'axios';

export const api = axios.create({
    baseURL: 'https://blogdotnetgen.herokuapp.com/'
})

export const login = async(url: any, dados: any, setToken: any, setId: any) => {
    const resposta = await api.post(url, dados)
    setToken(resposta.data.token)
    setId(resposta.data.userLogin.id)
}

export const cadastroUsuario = async(url: any, dados: any, setDado: any) => {
    const resposta = await api.post(url, dados)
    setDado(resposta.data)
}