/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var sass = require('gulp-sass');

gulp.task('default', function () {
    gulp.watch('Content/base.scss', ['sass']);
});

gulp.task('sass', function () {
    gulp.src('Content/*.scss')
        .pipe(sass())
        .pipe(gulp.dest('Content/'));
})