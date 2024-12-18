.PHONY: explain
explain:
    #                                                                                                                                                        
        #  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------.  .----------------. 
        # | .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
        # | | ____    ____ | || |      __      | || |  ___  ____   | || |  _________   | || |  _________   | || |     _____    | || |   _____      | || |  _________   | |
        # | ||_   \  /   _|| || |     /  \     | || | |_  ||_  _|  | || | |_   ___  |  | || | |_   ___  |  | || |    |_   _|   | || |  |_   _|     | || | |_   ___  |  | |
        # | |  |   \/   |  | || |    / /\ \    | || |   | |_/ /    | || |   | |_  \_|  | || |   | |_  \_|  | || |      | |     | || |    | |       | || |   | |_  \_|  | |
        # | |  | |\  /| |  | || |   / ____ \   | || |   |  __'.    | || |   |  _|  _   | || |   |  _|      | || |      | |     | || |    | |   _   | || |   |  _|  _   | |
        # | | _| |_\/_| |_ | || | _/ /    \ \_ | || |  _| |  \ \_  | || |  _| |___/ |  | || |  _| |_       | || |     _| |_    | || |   _| |__/ |  | || |  _| |___/ |  | |
        # | ||_____||_____|| || ||____|  |____|| || | |____||____| | || | |_________|  | || | |_____|      | || |    |_____|   | || |  |________|  | || | |_________|  | |
        # | |              | || |              | || |              | || |              | || |              | || |              | || |              | || |              | |
        # | '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
        #  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------'  '----------------' 
        #
    ### Targets
	    @cat Makefile* | grep -E '^[a-zA-Z_-]+:.*?## .*$$' | sort | awk 'BEGIN {FS = ":.*?## "}; {printf "\033[36m%-30s\033[0m %s\n", $$1, $$2}'

.PHONY: grpc
grpc: ## generates the client and server interfaces in go
	protoc --proto_path=Protos --go_out=Protos --go_opt=paths=source_relative  --go-grpc_out=Protos --go-grpc_opt=paths=source_relative Protos/*.proto

.PHONY: grpc_csharp
grpc_csharp:  ## generates the client and server interfaces for C#
	@echo "Generating C# gRPC client and server code..."
	protoc --proto_path=Protos \
	       --proto_path=C:/Users/niroo/.nuget/packages/grpc.tools/2.40.0/build/native/include \
	       --csharp_out=Generated \
	       --grpc_out=Generated \
	       --plugin=protoc-gen-grpc=C:/Users/niroo/.nuget/packages/grpc.tools/2.40.0/tools/windows_x64/grpc_csharp_plugin.exe \
	       Protos/*.proto
	@echo "C# gRPC client and server code generation completed!"
