import os
import json
import UnityPy

asset_path = "DMM/tagatame/new_win32/"
asset_list = "asset_list.csv"
event_path = "Events/"
bg_path = "../../docs/img/backgrounds/"

events = {}
assets = {}
bgs = set()

with open(asset_list, "r", encoding="utf-8") as f:
    for line in f:
        file, path, typ, name, external_name = line.strip().split(',')
        assets[external_name] = file
        if typ == "MonoBehaviour" and path.startswith("assets/resources/events/"):
            events[file] = name

# From: https://github.com/K0lb3/UnityPy/issues/41
def get_obj_pptr(env, objref, file_id : int, path_id : int):
    if path_id == 0:
        return None

    manager = None
    if file_id == 0:
        manager = objref.assets_file
    elif file_id > 0 and file_id - 1 < len(objref.assets_file.externals):
        external_name = objref.assets_file.externals[file_id - 1].name
        file = assets[external_name]
        print(f"Loading {file}...")
        file = os.path.join(asset_path, file)
        manager = UnityPy.load(file).objects[0].assets_file

    if manager and path_id in manager.objects:
        return manager.objects[path_id]
    return None

for file in events:
    # Load the bundle
    print(f"Loading {file}...")
    env = UnityPy.load(os.path.join(asset_path, file))
    
    # Iterate through the objects in the bundle
    for path, obj in env.container.items():
        if obj.type.name == "MonoBehaviour":
            tree = obj.read_typetree()
            event = {"Name": tree["m_Name"], "Bundle": file, "Path": path, "Actions": []}
            for sequence in tree["mSequences"]:
                for action in sequence["Actions"]:
                    action_obj = get_obj_pptr(env, obj, action["m_FileID"], action["m_PathID"])
                    if action_obj.type.name == "MonoBehaviour":
                        action_tree = action_obj.read_typetree()
                        for key in ("m_GameObject", "m_Enabled", "m_Script"):
                            del action_tree[key]
                        if "Background" in action_tree or "BackgroundImage" in action_tree:
                            bg = action_tree.get("Background", action_tree.get("BackgroundImage"))
                            if bg["m_FileID"] == 0 and bg["m_PathID"] == 0:
                                continue
                            bg_obj = get_obj_pptr(env, action_obj, bg["m_FileID"], bg["m_PathID"])
                            assert bg_obj.type.name == "Texture2D"
                            bg_data = bg_obj.read()
                            # bundle = file
                            # if bg["m_FileID"] > 0:
                            #     bundle = assets[action_obj.assets_file.externals[bg["m_FileID"] - 1].name]
                            # bg_name = f"{bundle}_{bg_data.name}"
                            # Note: bgs with the same filename in different bundles are duplicates
                            bg_name = bg_data.name
                            if bg_name not in bgs:
                                bgs.add(bg_name)
                                print(f"Saving {bg_name}.png...")
                                bg_data.image.save(os.path.join(bg_path, f"{bg_name}.png"))
                            if "Background" in action_tree:
                                action_tree["Background"] = bg_name
                            else:
                                action_tree["BackgroundImage"] = bg_name
                        event["Actions"].append(action_tree)
    
    # Save the event to a file
    print(f"Saving {events[file]}.json...")
    with open(os.path.join(event_path, f"{events[file]}.json"), "w", encoding="utf-8") as f:
        f.write(json.dumps(event, indent=4, ensure_ascii=False))
