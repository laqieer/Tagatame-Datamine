import os
import requests
import warnings

assets_ex = '39c5254f'

with open('DMM/tagatame/new_win32/UnmanagedAssetListHash', 'r', encoding='utf-8') as f:
    assets_ex = f.readlines()[1].strip()

with open('DMM/tagatame/new_win32/UnmanagedAssetList', 'r', encoding='utf-8') as f_list:
    for line in f_list:
        line = line.strip()
        if line:
            path, size = line.split('\t')
            save_path = os.path.join('UnmanagedAsset/', path)
            if os.path.exists(save_path) and os.path.getsize(save_path) == int(size):
                    continue
            url = f'https://alchemist-dlc2.gu3.jp/assets_ex/{assets_ex}/{path}'
            print(f'Downloading {url} to {save_path}')
            response = requests.get(url)
            if response.status_code == 200:
                os.makedirs(os.path.dirname(save_path), exist_ok=True)
                with open(save_path, 'wb') as f:
                    f.write(response.content)
            else:
                warnings.warn(f'Failed to download {path}: {response.status_code} {response.text}')
