#!/usr/bin/env bash

set -eux

ROOT=$(cd $(dirname $0); pwd)

PROJECT="$ROOT"/"$1"

mkdir "$PROJECT"
(cd "$PROJECT"; 
 dotnet new console; 
 echo "$ROOT"/gitignore > .gitignore; 
 git add -A; 
 cd "$ROOT"
 dotnet sln add "$PROJECT"/"$1".csproj
 git add CSSandbox.sln
 git commit -m "Add dotnet-new console project \"$1\"")
