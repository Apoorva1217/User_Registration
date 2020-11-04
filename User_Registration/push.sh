read a
git branch $a
git checkout $a
git add .
git commit -m "[Apoorva] Refactor . Refactored the code to use Lambda function to validate user entry"
git push origin $a
git checkout master
git merge $a
git push origin master --force
