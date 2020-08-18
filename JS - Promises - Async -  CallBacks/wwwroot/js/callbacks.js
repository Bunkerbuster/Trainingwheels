const callback_posts = [
    { title: 'Callback Post One', body: 'This is post one' },
    { title: 'Callback Post two', body: 'This is post two ' }
];

function getcallback_Posts() {

    setTimeout(() => {
        let output = '';

        callback_posts.forEach((post, index) => {

            // speciale back quote zo dat je javascript in text kunt gebruiken
            output += `<li>${post.title}</li>`;
        })

        document.body.innerHTML = output;

    }, 1000);
}



// standaard is de functie met 1 variable, maar omdat de functie createpost 2 seconden duurt
// en de functie getPosts 1 seconde duurt en deze niet wacht op createpost wordt de waarde niet 
// op de pagina geschreven.
// zodoende passen we onderstaan de als volgt aan
//  function createPost(post) {
//        setTimeout(() => {
//            posts.push(post);
//      }, 2000);
//  }
//  getPosts();
//
//  createPost({ title: 'Post Three', body: 'This os post Three' })
//
// we voegen een callback functie toe aan de createpost
function createcallback_Post(post, callback)
{
    setTimeout(() => {
        callback_posts.push(post);
        // en voegen een callback toe aan deze timeout
        //if (callback)
        callback();  
    }, 2000);
}
// en voegen de fucntie getPosts() toe aan het aanroepen van de functie
createcallback_Post({ title: 'Callback Post Three', body: 'This is post Three' }, getcallback_Posts);
