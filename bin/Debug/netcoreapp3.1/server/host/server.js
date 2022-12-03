const express = require('express');
var app = express()
var val = Math.floor(1000 + Math.random() * 9000)
app.listen(val, () => {
    console. log("")
})
