#!/bin/bash

repos=( 
  "aws-training/zengqiang.fang-week1"
  "aws-training/zengqiang.fang-week2"
)

echo ""
echo "Getting latest for" ${#repos[@]} "repositories using pull --rebase"

for repo in "${repos[@]}"
do
  echo ""
  echo "****** Getting latest for" ${repo} "******"
  cd "${repo}"
  git pull --rebase
  echo "******************************************"
done
