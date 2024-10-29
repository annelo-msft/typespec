import "@typespec/http";
import "@typespec/rest";
import "@typespec/openapi3";

@service({
    title: "SimplePost",
  })
   
  namespace SimplePost;
   
  using TypeSpec.Http;
  using TypeSpec.Rest;
   
   
  interface SimplePostClient {
    @post @route("add") IncrementCount(@path addend: int32) : int32;
  }