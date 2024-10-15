// Decompiled with JetBrains decompiler
// Type: SRPG.Scene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010F8")]
  public abstract class Scene : MonoBehaviour
  {
    [Token(Token = "0x17000773")]
    protected bool IsLoaded
    {
      [Token(Token = "0x60047F0"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
      [Token(Token = "0x60047F1"), Address(RVA = "0x3DA460", Offset = "0x3D9260", VA = "0x103DA460")] set
      {
      }
    }

    [Token(Token = "0x60047F2")]
    [Address(RVA = "0x11F3890", Offset = "0x11F2690", VA = "0x111F3890")]
    protected void Awake()
    {
    }

    [Token(Token = "0x60047F3")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    protected Scene()
    {
    }
  }
}
