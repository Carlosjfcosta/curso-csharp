// =====================================================================
// AULA 08 · GIT E GITHUB · minhas anotações
// =====================================================================
// Git    = o sistema de saves do jogo, na minha máquina (funciona sem internet).
// GitHub = a nuvem de saves: uma cópia do histórico no site github.com.
// Meu repositório: https://github.com/Carlosjfcosta/curso-csharp
// Os comandos vão no terminal do VS Code, dentro de C:\VS CODE\Aula C#.

// ---------------------------------------------------------------------
// ANTES DE TUDO · uma vez em cada máquina
// ---------------------------------------------------------------------
// git --version                                  -> confere se o Git está instalado
// git config --global user.name "Carlos"         -> meu nome, gravado em cada save
// git config --global user.email "meu e-mail"    -> o mesmo e-mail da conta do GitHub
// git config --global init.defaultBranch main    -> o histórico começa com o nome main
// git config --global pull.rebase true           -> no pull, meus saves vão depois dos da nuvem
// git config --global --list                     -> mostra o que ficou gravado
//
// Os git config não mostram nada quando dão certo.
// Texto de exemplo (e-mail, SEU-USUARIO) é para TROCAR, não para copiar.

// ---------------------------------------------------------------------
// 08.1 · GIT NA MÁQUINA
// ---------------------------------------------------------------------
// git init
//   Liga os saves na pasta: cria a pasta escondida .git.
//   Uma vez só, na pasta do curso inteira (não dentro de um projeto).
//
// git status
//   O painel da viatura: mostra o que mudou, o que foi separado e o que já está salvo.
//   Não muda nada. Rodar antes e depois de cada comando.
//   "Untracked files"    -> o Git vê, mas ainda não guarda (no VS Code: verde com U)
//   "working tree clean" -> tudo salvo
//
// dotnet new gitignore
//   Cria o .gitignore: a lista do que o Git finge que não existe.
//   Deixa de fora bin/ e obj/, que o dotnet run refaz a cada build.
//   Receita x comida pronta: guardo o Program.cs e o .csproj (a receita),
//   e não o bin (a comida pronta) nem o obj (as panelas do preparo).
//   Criar ANTES do primeiro save: o que entra no histórico fica lá.
//
// git add .
//   Separa tudo o que mudou para o próximo save (separar os documentos na mesa).
//   Ainda não salva nada.
//
// git commit -m "Adiciona o exercício X"
//   Salva o que foi separado, com uma descrição (lacrar o envelope com a etiqueta).
//   A mensagem começa com verbo e diz o que mudou.
//   Sem o -m, abre um editor no terminal: Esc, digita :q! e Enter.
//   "nothing added to commit" -> faltou o git add .
//
// git log --oneline
//   A lista de saves, o mais novo em cima. HEAD -> main = "você está aqui".
//   Meu primeiro save: 19516ed Adiciona os exercícios do curso (43 arquivos).
//
// git restore Aula05/Program.cs
//   Volta o arquivo para o último save (carregar o save do jogo).
//   O que mudei nesse arquivo desde o último save se perde, sem volta.

// ---------------------------------------------------------------------
// 08.2 · GITHUB
// ---------------------------------------------------------------------
// No site: New repository -> nome curso-csharp -> VAZIO (sem README).
// O endereço certo aparece na caixa "Quick setup".
//
// git remote add origin https://github.com/Carlosjfcosta/curso-csharp.git
//   Salva o endereço do GitHub com o apelido origin (salvar um contato no celular).
//   Uma vez só por pasta. O clone já vem com o origin salvo.
// git remote set-url origin <endereço certo>  -> corrige o endereço (editar o contato)
// git remote -v                               -> mostra o endereço gravado
//   "remote origin already exists" -> o origin já existe: use set-url, e não add
//   "Repository not found"         -> endereço errado ou repositório não criado no site
//
// git push -u origin main
//   Sobe os saves para a nuvem. O -u grava a ligação; depois, basta git push.
//   No primeiro push, o navegador abre para entrar na conta (sem senha no terminal).
//
// git clone https://github.com/Carlosjfcosta/curso-csharp.git "Aula C#"
//   Baixa a pasta inteira, com todo o histórico, já ligada ao GitHub.
//   Uma vez em cada máquina, em C:\VS CODE (nunca dentro da pasta do curso).
//
// git pull
//   Recebe os saves que a outra máquina subiu (receber a passagem de serviço).
//
// Push recusado: "! [rejected] main -> main (fetch first)"
//   A nuvem tem um save que eu não tenho. Nada quebrou:
//   git pull e depois git push de novo.

// ---------------------------------------------------------------------
// A ROTINA · passagem de serviço entre o PC e o notebook
// ---------------------------------------------------------------------
// Sentou para estudar: git pull
// Levantou:            git add .  ->  git commit -m "..."  ->  git push

Console.WriteLine("Aula 08 - Git e GitHub");
Console.WriteLine("Sentou: git pull.");
Console.WriteLine("Levantou: git add . / git commit -m \"...\" / git push.");
