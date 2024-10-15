// Decompiled with JetBrains decompiler
// Type: SRPG.BaseManager`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021B1")]
  public abstract class BaseManager<B> : MonoBehaviour where B : MonoBehaviour
  {
    [Token(Token = "0x4009395")]
    [FieldOffset(Offset = "0x0")]
    private static B mInstance;

    [Token(Token = "0x17001404")]
    public static B Instance
    {
      [Token(Token = "0x6008DDB")] get => (B) null;
    }

    [Token(Token = "0x6008DDC")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x6008DDD")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x6008DDE")]
    private IEnumerator LoadAssetCoroutine<T>(
      string name,
      BaseManager<B>.LoadAssetCallback<T> callback)
      where T : UnityEngine.Object
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008DDF")]
    private bool InternalLoadAssets<T>(string name, BaseManager<B>.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x6008DE0")]
    public static bool LoadAssets<T>(string name, BaseManager<B>.LoadAssetCallback<T> callback) where T : UnityEngine.Object
    {
      return new bool();
    }

    [Token(Token = "0x6008DE1")]
    protected BaseManager()
    {
    }

    [Token(Token = "0x20021B2")]
    public delegate void LoadAssetCallback<T>(T obj)
      where B : MonoBehaviour
      where T : UnityEngine.Object;
  }
}
