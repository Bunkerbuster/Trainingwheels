const promise_posts = [
    { title: 'Promise Post One', body: 'This is post one' },
    { title: 'Promise Post two', body: 'This is post two ' }
];

function getpromise_Posts() {

    setTimeout(() => {
        let output = '';

        promise_posts.forEach((post, index) => {

            // speciale back quote zo dat je javascript in text kunt gebruiken
            output += `<li>${post.title}</li>`;
        })

        document.body.innerHTML = output;

    }, 1000);
}

function createpromise_post(post) {

    return new Promise((resolve, reject) => {

        setTimeout(() => {
            promise_posts.push(post);

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


createpromise_post({ title: 'Promise post three', body: 'this is post three' })
    .then(getpromise_Posts)
    .catch(err => console.log(err));


// connecting multiple promisses
// Promise.All

const promise1 = Promise.resolve('Hello World');
const promise2 = 10;
const promise3 = new Promise((resolve, reject) => setTimeout(resolve, 2000, 'Goodbye'));

// let op dubbele then bij een fetch
// 
const promise4 = fetch('https://jsonplaceholder.typicode.com/users').then(res => res.json());

Promise.all([promise1, promise2, promise3, promise4]).then(values => console.log(values));


