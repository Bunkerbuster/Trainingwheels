const async_posts = [
    { title: 'async Post One', body: 'This is post one' },
    { title: 'async Post two', body: 'This is post two ' }
];

function getasync_Posts() {

    setTimeout(() => {
        let output = '';

        async_posts.forEach((post, index) => {

            // speciale back quote zo dat je javascript in text kunt gebruiken
            output += `<li>${post.title}</li>`;
        })

        document.body.innerHTML = output;

    }, 1000);
}

function createasync_Post(post) {

    return new Promise((resolve, reject) => {

        setTimeout(() => {
            async_posts.push(post);

            const error = false;

            if (!error)
            {
                resolve();
            } else
            {
                reject('Error: something went wrong');
            }
        }, 2000);
    })
}

//createpromise_post({ title: 'Promise post three', body: 'this is post three' })
//    .then(getpromise_Posts)
//    .catch(err => console.log(err));

async function init()
{
    await createasync_Post({ title: 'async Post three', body: 'this is post three' });

    getasync_Posts();
}
init();


//async await with fetch
async function fetchUsers()
{
    const res = await fetch('https://jsonplaceholder.typicode.com/users');
    const data = await res.json();

    console.log("NEW Call => ");
    console.log(data);
}

fetchUsers();