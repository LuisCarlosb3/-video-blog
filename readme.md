# Gerenciador de videos

## Rotas disponíveis
- [X] `/videos` -> Listar todos os videos
- [X] `/videos/<id>` -> pegar um video pelo ID
- [X] `/videos` -> criar um novo video com todos os campos validados
- [X] `/videos/` -> edita os campos de um video
- [X] `/videos/<id>` -> deleta um video pelo ID
- [ ] `/videos/?search=<termo>` -> busca um video com titulo relacionado
- [X] `/categorias` -> lista todas as categorias
- [ ] `/categorias/<id>` -> pega uma categoria especifica 
- [ ] `/categorias` -> cria uma categoria nova e retorna o objeto criado
- [ ] `/categorias/<id>` -> atualiza uma categoria
- [ ] `/categorias/<id>` -> deleta uma categoria 
- [ ] `categorias/<id>/videos/` -> retorna todos os videos da categoria

## Regras
 - A categoria com ID = 1, deve chamar LIVRE e caso ela não seja especificada na criação do vídeo, vamos atribuir o ID = 1.
 - Todos os campos do video devem ser preenchidos
 - Todos os campos de categoria devem ser preenchidas
 - Não se pode ter mais de uma categroia com o mesmo nome
 