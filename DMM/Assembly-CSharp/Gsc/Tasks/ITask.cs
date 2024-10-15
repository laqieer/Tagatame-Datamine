// Decompiled with JetBrains decompiler
// Type: Gsc.Tasks.ITask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace Gsc.Tasks
{
  [Token(Token = "0x200354F")]
  public interface ITask
  {
    [Token(Token = "0x170021CD")]
    bool isDone { [Token(Token = "0x600EC4A")] get; }

    [Token(Token = "0x600EC4B")]
    void OnStart();

    [Token(Token = "0x600EC4C")]
    IEnumerator Run();

    [Token(Token = "0x600EC4D")]
    void OnFinish();
  }
}
