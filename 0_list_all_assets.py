import UnityPy
import os

asset_path = "DMM/tagatame/new_win32/"
asset_list = "asset_list.csv"

with open(asset_list, "w", encoding="utf-8") as f:
    f.write("Bundle,Path,Type,Name,ExternalName\n")
    for file in os.listdir(asset_path):
        # check if the filename is a valid number in hexidecimal
        try:
            int(file, 16)
        except:
            continue
        
        # Load the bundle
        print(f"Loading {file}...")
        env = UnityPy.load(os.path.join(asset_path, file))
        
        # Iterate through the objects in the bundle
        for path, obj in env.container.items():
            if obj.type.name in ("Texture2D", "Sprite", "TextAsset", "Font", "MonoBehaviour"):
                data = obj.read()
                f.write(','.join([file, path, obj.type.name, data.name, obj.assets_file.name]) + '\n')
