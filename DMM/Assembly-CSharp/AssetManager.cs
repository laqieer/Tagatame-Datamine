// Decompiled with JetBrains decompiler
// Type: AssetManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000084")]
[AddComponentMenu("Common/AssetManager")]
public class AssetManager : MonoBehaviour
{
  [Token(Token = "0x4000293")]
  [FieldOffset(Offset = "0x0")]
  private static AssetManager mInstance;
  [Token(Token = "0x4000294")]
  [FieldOffset(Offset = "0x4")]
  public static readonly string EMBEDED_SCENE_SUFFIX;
  [Token(Token = "0x4000295")]
  [FieldOffset(Offset = "0x8")]
  private static bool bUseDLC;
  [Token(Token = "0x4000296")]
  [FieldOffset(Offset = "0x9")]
  private static bool mIsRecordPrepareAssets;
  [Token(Token = "0x4000297")]
  [FieldOffset(Offset = "0xC")]
  private static Dictionary<uint, AssetList.Item> mRecordedPrepareAssets;
  [Token(Token = "0x4000298")]
  [FieldOffset(Offset = "0x10")]
  public static AssetManager.AssetFormats Format;
  [Token(Token = "0x4000299")]
  [FieldOffset(Offset = "0x14")]
  private static bool mInstanceCreated;
  [Token(Token = "0x400029A")]
  [FieldOffset(Offset = "0xC")]
  private List<AssetManager.ManagedScene> mScenes;
  [Token(Token = "0x400029B")]
  [FieldOffset(Offset = "0x10")]
  private List<AssetManager.ManagedAsset> mAssets;
  [Token(Token = "0x400029C")]
  [FieldOffset(Offset = "0x14")]
  private List<AssetManager.ManagedAsset> mLoadingAssets;
  [Token(Token = "0x400029D")]
  [FieldOffset(Offset = "0x18")]
  private List<AssetBundleCache> mAssetBundles;
  [Token(Token = "0x400029E")]
  [FieldOffset(Offset = "0x1C")]
  private bool mScriptsLoaded;
  [Token(Token = "0x400029F")]
  [FieldOffset(Offset = "0x20")]
  private List<SceneRequest> mSceneRequests;
  [Token(Token = "0x40002A0")]
  [FieldOffset(Offset = "0x24")]
  private List<string> mRemoveSceneAssetLists;
  [Token(Token = "0x40002A1")]
  [FieldOffset(Offset = "0x28")]
  private AssetList mAssetList;
  [Token(Token = "0x40002A2")]
  [FieldOffset(Offset = "0x18")]
  private static AssetList mAssetListRef;
  [Token(Token = "0x40002A3")]
  [FieldOffset(Offset = "0x2C")]
  private UnManagedAssetList mUnManagedList;

  [Token(Token = "0x17000079")]
  public static bool UseDLC
  {
    [Token(Token = "0x6000301"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")] get
    {
      return new bool();
    }
    [Token(Token = "0x6000302"), Address(RVA = "0xB7FC00", Offset = "0xB7EA00", VA = "0x10B7FC00")] set
    {
    }
  }

  [Token(Token = "0x1700007A")]
  public static bool IsRecordPrepareAssets
  {
    [Token(Token = "0x6000303"), Address(RVA = "0xB7FA50", Offset = "0xB7E850", VA = "0x10B7FA50")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000304")]
  [Address(RVA = "0xB7F3F0", Offset = "0xB7E1F0", VA = "0x10B7F3F0")]
  static AssetManager()
  {
  }

  [Token(Token = "0x1700007B")]
  public static AssetManager Instance
  {
    [Token(Token = "0x6000305"), Address(RVA = "0xB7F910", Offset = "0xB7E710", VA = "0x10B7F910")] get
    {
      return (AssetManager) null;
    }
  }

  [Token(Token = "0x1700007C")]
  public static bool HasInstance
  {
    [Token(Token = "0x6000306"), Address(RVA = "0xB7F8A0", Offset = "0xB7E6A0", VA = "0x10B7F8A0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700007D")]
  public static int MaxAssetBundles
  {
    [Token(Token = "0x6000307"), Address(RVA = "0xB7FA90", Offset = "0xB7E890", VA = "0x10B7FA90")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x6000308")]
  [Address(RVA = "0xB7A370", Offset = "0xB79170", VA = "0x10B7A370")]
  public static void CreateInstance()
  {
  }

  [Token(Token = "0x6000309")]
  [Address(RVA = "0xB7D4A0", Offset = "0xB7C2A0", VA = "0x10B7D4A0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600030A")]
  [Address(RVA = "0xB7E9E0", Offset = "0xB7D7E0", VA = "0x10B7E9E0")]
  public static void UnloadAll()
  {
  }

  [Token(Token = "0x600030B")]
  [Address(RVA = "0xB7A860", Offset = "0xB79660", VA = "0x10B7A860")]
  public static string[] GetLoadingAssetNames() => (string[]) null;

  [Token(Token = "0x600030C")]
  [Address(RVA = "0xB7A680", Offset = "0xB79480", VA = "0x10B7A680")]
  public static string[] GetLoadedAssetNames() => (string[]) null;

  [Token(Token = "0x600030D")]
  [Address(RVA = "0xB7AA40", Offset = "0xB79840", VA = "0x10B7AA40")]
  public static string[] GetOpenedAssetBundleNames() => (string[]) null;

  [Token(Token = "0x600030E")]
  [Address(RVA = "0xB7ECF0", Offset = "0xB7DAF0", VA = "0x10B7ECF0")]
  private void Update()
  {
  }

  [Token(Token = "0x600030F")]
  [Address(RVA = "0xB7EB60", Offset = "0xB7D960", VA = "0x10B7EB60")]
  public void UnloadUnusedAssetBundles(bool immediate = false, bool forceUnload = false)
  {
  }

  [Token(Token = "0x6000310")]
  [Address(RVA = "0xB7BF90", Offset = "0xB7AD90", VA = "0x10B7BF90")]
  private bool IsAssetBundleLoading(AssetBundleCache abc) => new bool();

  [Token(Token = "0x6000311")]
  [Address(RVA = "0xB7E020", Offset = "0xB7CE20", VA = "0x10B7E020")]
  private void OpenScriptAssetBundle()
  {
  }

  [Token(Token = "0x6000312")]
  [Address(RVA = "0xB7AF60", Offset = "0xB79D60", VA = "0x10B7AF60")]
  private LoadRequest InternalLoadAsync(string name, System.Type type) => (LoadRequest) null;

  [Token(Token = "0x6000313")]
  [Address(RVA = "0xB7ADB0", Offset = "0xB79BB0", VA = "0x10B7ADB0")]
  public static string GetStreamingAssetPath(string name) => (string) null;

  [Token(Token = "0x6000314")]
  [Address(RVA = "0xB7A300", Offset = "0xB79100", VA = "0x10B7A300")]
  public static string ConvertEmbededSceneName(string scene_name, bool is_force_embeded_name = false)
  {
    return (string) null;
  }

  [Token(Token = "0x6000315")]
  [Address(RVA = "0xB7A2B0", Offset = "0xB790B0", VA = "0x10B7A2B0")]
  public static string ConvertEmbededResourcesPath(string path) => (string) null;

  [Token(Token = "0x6000316")]
  [Address(RVA = "0xB7AF10", Offset = "0xB79D10", VA = "0x10B7AF10")]
  public static string GetUnManagedStreamingAssetPath(string name) => (string) null;

  [Token(Token = "0x6000317")]
  [Address(RVA = "0xB7C3E0", Offset = "0xB7B1E0", VA = "0x10B7C3E0")]
  public static LoadRequest LoadAsync(string name) => (LoadRequest) null;

  [Token(Token = "0x6000318")]
  public static LoadRequest LoadAsync<T>(string name) => (LoadRequest) null;

  [Token(Token = "0x6000319")]
  [Address(RVA = "0xB7C4F0", Offset = "0xB7B2F0", VA = "0x10B7C4F0")]
  public static LoadRequest LoadAsync(string name, System.Type type) => (LoadRequest) null;

  [Token(Token = "0x600031A")]
  public static T Load<T>(string name) where T : UnityEngine.Object => (T) null;

  [Token(Token = "0x600031B")]
  [Address(RVA = "0xB7D2A0", Offset = "0xB7C0A0", VA = "0x10B7D2A0")]
  public static UnityEngine.Object Load(string name, System.Type type) => (UnityEngine.Object) null;

  [Token(Token = "0x600031C")]
  [Address(RVA = "0xB7C110", Offset = "0xB7AF10", VA = "0x10B7C110")]
  private bool IsAssetBundleOpen(string name) => new bool();

  [Token(Token = "0x600031D")]
  [Address(RVA = "0xB7D7D0", Offset = "0xB7C5D0", VA = "0x10B7D7D0")]
  public AssetBundleCache OpenAssetBundleAndDependencies(
    AssetList.Item node,
    int refCount = 1,
    List<AssetBundleCache> result = null)
  {
    return (AssetBundleCache) null;
  }

  [Token(Token = "0x600031E")]
  [Address(RVA = "0xB7B680", Offset = "0xB7A480", VA = "0x10B7B680")]
  public UnityEngine.Object InternalLoad(string name, System.Type type) => (UnityEngine.Object) null;

  [Token(Token = "0x1700007E")]
  public static bool IsLoading
  {
    [Token(Token = "0x600031F"), Address(RVA = "0xB7F960", Offset = "0xB7E760", VA = "0x10B7F960")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000320")]
  [Address(RVA = "0xB7C210", Offset = "0xB7B010", VA = "0x10B7C210")]
  public static bool IsAssetBundle(string path) => new bool();

  [Token(Token = "0x6000321")]
  [Address(RVA = "0xB7CEA0", Offset = "0xB7BCA0", VA = "0x10B7CEA0")]
  public static string LoadTextData(string path) => (string) null;

  [Token(Token = "0x6000322")]
  [Address(RVA = "0xB7C590", Offset = "0xB7B390", VA = "0x10B7C590")]
  public static byte[] LoadBinaryData(string path) => (byte[]) null;

  [Token(Token = "0x1700007F")]
  public static int AssetRevision
  {
    [Token(Token = "0x6000323"), Address(RVA = "0xB7F850", Offset = "0xB7E650", VA = "0x10B7F850")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x17000080")]
  public static UnManagedAssetList UnManagedAsset
  {
    [Token(Token = "0x6000324"), Address(RVA = "0xB7FAA0", Offset = "0xB7E8A0", VA = "0x10B7FAA0")] get
    {
      return (UnManagedAssetList) null;
    }
  }

  [Token(Token = "0x6000325")]
  [Address(RVA = "0xB79FD0", Offset = "0xB78DD0", VA = "0x10B79FD0")]
  private void Awake()
  {
  }

  [Token(Token = "0x17000081")]
  public static AssetList AssetList
  {
    [Token(Token = "0x6000326"), Address(RVA = "0xB7F7C0", Offset = "0xB7E5C0", VA = "0x10B7F7C0")] get
    {
      return (AssetList) null;
    }
  }

  [Token(Token = "0x6000327")]
  [Address(RVA = "0xB7DB20", Offset = "0xB7C920", VA = "0x10B7DB20")]
  private AssetBundleCache OpenAssetBundle(
    string assetbundleID,
    bool persistent = false,
    bool isDependency = false)
  {
    return (AssetBundleCache) null;
  }

  [Token(Token = "0x6000328")]
  [Address(RVA = "0xB7D340", Offset = "0xB7C140", VA = "0x10B7D340")]
  private void OnApplicationQuit()
  {
  }

  [Token(Token = "0x6000329")]
  [Address(RVA = "0xB7C270", Offset = "0xB7B070", VA = "0x10B7C270")]
  public static bool IsAssetInCache(string assetID) => new bool();

  [Token(Token = "0x600032A")]
  [Address(RVA = "0xB7E0B0", Offset = "0xB7CEB0", VA = "0x10B7E0B0")]
  public static void PrepareAssets(string resourcePath)
  {
  }

  [Token(Token = "0x600032B")]
  [Address(RVA = "0xB7E160", Offset = "0xB7CF60", VA = "0x10B7E160")]
  public static void PrepareAssets(AssetList.Item node)
  {
  }

  [Token(Token = "0x600032C")]
  [Address(RVA = "0xB7E4C0", Offset = "0xB7D2C0", VA = "0x10B7E4C0")]
  private void ReleaseSceneAssetBundles()
  {
  }

  [Token(Token = "0x600032D")]
  [Address(RVA = "0xB7D730", Offset = "0xB7C530", VA = "0x10B7D730")]
  public static void OnSceneActivate(SceneRequest req)
  {
  }

  [Token(Token = "0x600032E")]
  [Address(RVA = "0xB7BD10", Offset = "0xB7AB10", VA = "0x10B7BD10")]
  private void InternalOnSceneActivate(SceneRequest req)
  {
  }

  [Token(Token = "0x600032F")]
  [Address(RVA = "0xB7E6A0", Offset = "0xB7D4A0", VA = "0x10B7E6A0")]
  public static void RemoveSceneAsset(string sceneName)
  {
  }

  [Token(Token = "0x6000330")]
  [Address(RVA = "0xB7EB10", Offset = "0xB7D910", VA = "0x10B7EB10")]
  public static void UnloadScene(string sceneName)
  {
  }

  [Token(Token = "0x6000331")]
  [Address(RVA = "0xB7CC00", Offset = "0xB7BA00", VA = "0x10B7CC00")]
  public static void LoadSceneImmediate(string sceneName, bool additive)
  {
  }

  [Token(Token = "0x6000332")]
  [Address(RVA = "0xB7C840", Offset = "0xB7B640", VA = "0x10B7C840")]
  public static SceneRequest LoadSceneAsync(string sceneName, bool additive) => (SceneRequest) null;

  [Token(Token = "0x6000333")]
  [Address(RVA = "0xB7EC30", Offset = "0xB7DA30", VA = "0x10B7EC30")]
  public static AsyncOperation UnloadUnusedAssets() => (AsyncOperation) null;

  [Token(Token = "0x6000334")]
  [Address(RVA = "0xB7BF60", Offset = "0xB7AD60", VA = "0x10B7BF60")]
  private AsyncOperation InternalUnloadUnusedAssets() => (AsyncOperation) null;

  [Token(Token = "0x6000335")]
  [Address(RVA = "0xB7FB30", Offset = "0xB7E930", VA = "0x10B7FB30")]
  private bool removeWeakAsset() => new bool();

  [Token(Token = "0x6000336")]
  [Address(RVA = "0xB7E930", Offset = "0xB7D730", VA = "0x10B7E930")]
  public static bool RemoveWeakAsset() => new bool();

  [Token(Token = "0x6000337")]
  [Address(RVA = "0xB7AC20", Offset = "0xB79A20", VA = "0x10B7AC20")]
  public static string GetPath(AssetList.Item item) => (string) null;

  [Token(Token = "0x6000338")]
  [Address(RVA = "0xB79F10", Offset = "0xB78D10", VA = "0x10B79F10")]
  private static void AddRecordPrepareAsset(AssetList.Item item)
  {
  }

  [Token(Token = "0x6000339")]
  [Address(RVA = "0xB7A250", Offset = "0xB79050", VA = "0x10B7A250")]
  public static void ClearRecordPrepareAssets()
  {
  }

  [Token(Token = "0x600033A")]
  [Address(RVA = "0xB7AC80", Offset = "0xB79A80", VA = "0x10B7AC80")]
  public static Dictionary<uint, AssetList.Item> GetRecordPrepareAssets()
  {
    return (Dictionary<uint, AssetList.Item>) null;
  }

  [Token(Token = "0x600033B")]
  [Address(RVA = "0xB7A210", Offset = "0xB79010", VA = "0x10B7A210")]
  public static void Begin_RecordPrepareAssets()
  {
  }

  [Token(Token = "0x600033C")]
  [Address(RVA = "0xB7A590", Offset = "0xB79390", VA = "0x10B7A590")]
  public static void End_RecordPrepareAssets()
  {
  }

  [Token(Token = "0x600033D")]
  [Address(RVA = "0xB7C2E0", Offset = "0xB7B0E0", VA = "0x10B7C2E0")]
  public static bool IsExistResourcesFile(string path, string extension) => new bool();

  [Token(Token = "0x600033E")]
  [Address(RVA = "0xB7F610", Offset = "0xB7E410", VA = "0x10B7F610")]
  public AssetManager()
  {
  }

  [Token(Token = "0x2000085")]
  public enum AssetFormats
  {
    [Token(Token = "0x40002A5")] AndroidGeneric,
    [Token(Token = "0x40002A6")] AndroidDXT,
    [Token(Token = "0x40002A7")] AndroidPVR,
    [Token(Token = "0x40002A8")] AndroidATC,
    [Token(Token = "0x40002A9")] AndroidETC2,
    [Token(Token = "0x40002AA")] iOS,
    [Token(Token = "0x40002AB")] Windows,
  }

  [Token(Token = "0x2000086")]
  private class ManagedScene
  {
    [Token(Token = "0x40002AC")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x40002AD")]
    [FieldOffset(Offset = "0xC")]
    public List<AssetBundleCache> AssetBundles;
    [Token(Token = "0x40002AE")]
    [FieldOffset(Offset = "0x10")]
    public SceneRequest Request;

    [Token(Token = "0x600033F")]
    [Address(RVA = "0xB8D740", Offset = "0xB8C540", VA = "0x10B8D740")]
    public void Drop()
    {
    }

    [Token(Token = "0x6000340")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ManagedScene()
    {
    }
  }

  [Token(Token = "0x2000087")]
  private class ManagedAsset
  {
    [Token(Token = "0x40002AF")]
    [FieldOffset(Offset = "0x8")]
    public string Name;
    [Token(Token = "0x40002B0")]
    [FieldOffset(Offset = "0xC")]
    public int HashCode;
    [Token(Token = "0x40002B1")]
    [FieldOffset(Offset = "0x10")]
    public bool HasError;
    [Token(Token = "0x40002B2")]
    [FieldOffset(Offset = "0x14")]
    public System.Type AssetType;
    [Token(Token = "0x40002B3")]
    [FieldOffset(Offset = "0x18")]
    public UnityWeakReference<UnityEngine.Object> Object_Weak;
    [Token(Token = "0x40002B4")]
    [FieldOffset(Offset = "0x1C")]
    public WeakReference Request_Weak;
    [Token(Token = "0x40002B5")]
    [FieldOffset(Offset = "0x20")]
    public LoadRequest Request_Strong;
    [Token(Token = "0x40002B6")]
    [FieldOffset(Offset = "0x24")]
    public List<AssetBundleCache> AssetBundles;
    [Token(Token = "0x40002B7")]
    [FieldOffset(Offset = "0x28")]
    public bool IsIndependent;

    [Token(Token = "0x6000341")]
    [Address(RVA = "0xB8D680", Offset = "0xB8C480", VA = "0x10B8D680")]
    public void Drop()
    {
    }

    [Token(Token = "0x6000342")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ManagedAsset()
    {
    }
  }

  [Token(Token = "0x2000088")]
  public class RecordPrepareAssetsScope : IDisposable
  {
    [Token(Token = "0x6000343")]
    [Address(RVA = "0xB8D990", Offset = "0xB8C790", VA = "0x10B8D990")]
    public RecordPrepareAssetsScope()
    {
    }

    [Token(Token = "0x6000344")]
    [Address(RVA = "0xB8D910", Offset = "0xB8C710", VA = "0x10B8D910", Slot = "4")]
    public void Dispose()
    {
    }
  }
}
