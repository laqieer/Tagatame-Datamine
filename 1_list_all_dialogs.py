import UnityPy
import os

asset_path = "DMM/tagatame/new_win32/"
asset_list = "asset_list.csv"
dialog_list = "dialog_list.csv"

files = []
with open(asset_list, "r", encoding="utf-8") as f:
	for line in f:
		file, path = line.strip().split(',')[:2]
		if path.startswith("assets/resources/events/"):
			files.append(file)

# From: https://github.com/K0lb3/UnityPy/issues/41#issuecomment-812130128
def get_obj_pptr(env, objref, file_id : int, path_id : int):
	if path_id == 0:
		return None

	manager = None
	if file_id == 0:
		manager = objref.assets_file
	elif file_id > 0 and file_id - 1 < len(objref.assets_file.externals):
		external_name = objref.assets_file.externals[file_id - 1].name
		parent = objref.assets_file.parent
		if parent is not None:
			if external_name not in parent.files:
				external_name = external_name.upper()
			if external_name in parent.files:
				manager = parent.files[external_name]
		else:
			if external_name not in env.files:
				typ, reader = ImportHelper.check_file_type(external_name)
				if typ == FileType.AssetsFile:
					env.files[external_name] = files.SerializedFile(reader)
			if external_name in env.files:
				manager = env.files[external_name]

	if manager and path_id in manager.objects:
		return manager.objects[path_id]
	return None

with open(dialog_list, "w", encoding="utf-8") as f:
    f.write("TextID,ActorID,UnitID,CharaID\n")
    for file in files:
        # Load the bundle
        print(f"Loading {file}...")
        env = UnityPy.load(os.path.join(asset_path, file))
        
        # Iterate through the objects in the bundle
        for path, obj in env.container.items():
            if obj.type.name == "MonoBehaviour":
                tree = obj.read_typetree()
                for sequence in tree["mSequences"]:
                    for action in sequence["Actions"]:
                        action_obj = get_obj_pptr(env, obj, action["m_FileID"], action["m_PathID"])
                        if action_obj.type.name == "MonoBehaviour":
                            action_tree = action_obj.read_typetree()
                            if "TextID" in action_tree:
                                f.write(','.join([action_tree["TextID"], action_tree["ActorID"], action_tree.get("UnitID", ""), action_tree.get("CharaID", "")]) + '\n')
