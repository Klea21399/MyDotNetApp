# Path i folder-it lokal të projektit
$repoPath = "C:\Users\klea.canaj\Projects\MyDotnetApp"

# Branch aktual që do bëhet push
$branch = git -C $repoPath rev-parse --abbrev-ref HEAD

Write-Host "Monitoring $repoPath on branch $branch..." -ForegroundColor Cyan

while ($true) {
    try {
        # Shko në folder
        Set-Location $repoPath

        # Kontrollo nëse ka ndryshime
        $status = git status --porcelain

        if ($status) {
            Write-Host "$(Get-Date -Format u) → Ndryshime gjetur. Bëj commit dhe push..." -ForegroundColor Yellow

            git add .
            git commit -m "Auto commit at $(Get-Date -Format u)"
            git push origin $branch

            Write-Host "$(Get-Date -Format u) → Push përfundoi me sukses ✅" -ForegroundColor Green
        } else {
            Write-Host "$(Get-Date -Format u) → Nuk ka ndryshime." -ForegroundColor Gray
        }
    } catch {
        Write-Host "Gabim: $_" -ForegroundColor Red
    }

    # Pris 60 sekonda para rishikimit të folder-it
    Start-Sleep -Seconds 60
}
