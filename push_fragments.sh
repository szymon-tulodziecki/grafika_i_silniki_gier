#!/bin/bash

echo "=== Pushowanie zmian z pr_dom_2 w partiach ==="
echo ""

# Funkcja do commit i push
commit_and_push() {
    local path="$1"
    local message="$2"
    echo "--- Dodaję: $path ---"
    git add "$path"
    git commit -m "$message"
    if [ $? -eq 0 ]; then
        echo "Pushuję..."
        git push
        echo "✓ Gotowe!"
        sleep 2
    else
        echo "⚠ Brak zmian lub błąd"
    fi
    echo ""
}

# Najpierw .gitignore
commit_and_push ".gitignore" "Add .gitignore for Unity projects"

# Potem główne foldery Assets w partiach
commit_and_push "pr_dom_2/Assets/*.meta" "Update pr_dom_2 meta files"
commit_and_push "pr_dom_2/Assets/*.cs" "Update pr_dom_2 scripts"
commit_and_push "pr_dom_2/Assets/*.inputactions" "Update pr_dom_2 input actions"
commit_and_push "pr_dom_2/Assets/*.mat" "Update pr_dom_2 materials"

# Asset packs osobno
commit_and_push "pr_dom_2/Assets/3D\ Gamekit\ -\ Environment\ Pack/" "Update 3D Gamekit Environment Pack"
commit_and_push "pr_dom_2/Assets/Mini\ First\ Person\ Controller/" "Update Mini First Person Controller"
commit_and_push "pr_dom_2/Assets/Materials/" "Update Materials"
commit_and_push "pr_dom_2/Assets/Scenes/" "Update Scenes"

# Packages i ProjectSettings
commit_and_push "pr_dom_2/Packages/" "Update pr_dom_2 Packages"
commit_and_push "pr_dom_2/ProjectSettings/" "Update pr_dom_2 ProjectSettings"

# Reszta pr_dom_2 co zostało
commit_and_push "pr_dom_2/" "Update remaining pr_dom_2 files"

echo "=== Wszystko spushowane! ==="
