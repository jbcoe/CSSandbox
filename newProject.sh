#!/usr/bin/env bash

set -eux

ROOT=$(cd $(dirname $0); pwd)

PROJECT="$ROOT"/"$1"

mkdir "$PROJECT"
(cd "$PROJECT"; 
 dotnet new console; 
 git init; 
 echo "$ROOT"/gitignore > .gitignore; 
 git add -A; 
 git commit -m 'Add dotnet-new console project "$1"')
