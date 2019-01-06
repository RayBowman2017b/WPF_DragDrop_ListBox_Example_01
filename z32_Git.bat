@rem z32_Git.bat
@rem   WPF_DragDrop_ListBox_Example_01

@rem echo "# WPF_DragDrop_ListBox_Example_01" >> README.md
@rem 
@rem 
git init
@rem
git add README.md
@rem
git add .
@rem git rm --cached z32_Git.bat
@rem git rm --cached -r Reorder_item_WPF\z32_OLD_CODE\

git commit -m "first commit"
@rem
git remote add origin git@github.com:RayBowman2017b/WPF_DragDrop_ListBox_Example_01.git
git push -u origin master
pause
