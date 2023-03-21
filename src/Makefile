XBUILD=/Applications/Xcode_14.2.0.app/Contents/Developer/usr/bin/xcodebuild
ROOT=$(PWD)
PROJECT_ROOT=$(ROOT)/../external/AdaptiveCards
PROJECT_IOS=$(PROJECT_ROOT)/source/ios/AdaptiveCards/AdaptiveCards/AdaptiveCards.xcodeproj
BUILD_ROOT=$(PROJECT_ROOT)/build
TARGET_IOS="AdaptiveCards"
PROJECTNAME=AdaptiveCards
FRAMEWORKS=$(ROOT)/Frameworks
IOS_SDK=iphoneos16.2
BINDING_OUTPUT=$(ROOT)/../bindings
HEADERS=$(FRAMEWORKS)/iOS_Simulator/AdaptiveCards.framework/Headers

pod:
	pod install

xcframework:
	mkdir -p $(FRAMEWORKS)
	rm -rf $(FRAMEWORKS)/$(PROJECTNAME).xcframework
	$(XBUILD) -create-xcframework -framework $(FRAMEWORKS)/iOS/AdaptiveCards.framework -framework $(FRAMEWORKS)/Catalyst/AdaptiveCards.framework -framework $(FRAMEWORKS)/iOS_Simulator/AdaptiveCards.framework -output $(FRAMEWORKS)/$(PROJECTNAME).xcframework

sharpie:
	sharpie bind --sdk=$(IOS_SDK) --output="$(BINDING_OUTPUT)" --namespace="Drastic.$(PROJECTNAME)" --scope="$(HEADERS)" $(HEADERS)/ACOResourceResolvers.h