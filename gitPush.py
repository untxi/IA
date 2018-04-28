# actualizar git
import os
commitMessage = "git commit -m " + str(input("Commit Message: "))

os.system('git config --global user.name "Sammy Arburola"')
os.system('git config --global user.email samarburola@gmail.com')
os.system('git add .')
os.system(commitMessage)
os.system('git push')
print("Done!")
